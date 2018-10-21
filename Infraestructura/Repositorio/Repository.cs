using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

using Aplication.Enums;
using Domain.Base.Entity;
using Domain.Base.Repository;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Infraestructura.Context;
using Infrastructure.Context;

namespace Infrastructure
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly EfDbContext _context;
        
        GoogleContext _googleContext;
        public Repository(EfDbContext context)
        {
            if(_googleContext==null)
            {
                _googleContext = new GoogleContext();
            }
            if (this._context == null)
                this._context = context;
        }

        public void Add(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException($"La entidad {nameof(entity)} no puede ser null");


                var array = entity.GetType().GetProperties().Select(s => s.GetValue(entity)).ToList();
                var rangeValue = new List<IList<object>>() { array };
                var valueRange = new ValueRange()
                {
                    Range = _googleContext.range,
                    MajorDimension = "ROWS",
                    Values = rangeValue,
                };
               var request= _googleContext.Service.Spreadsheets.Values.Append(valueRange, _googleContext.spreadsheetId, _googleContext.range);
                request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                var response=request.Execute();
                if (response.Updates.UpdatedRows == 0)
                    throw new Exception("No se realizó ninguna edición en la base de datos.");
                
              
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    
        public IEnumerable<T> GetAll(string includeProperties = null)
        {
            try
            {
                var request = _googleContext.Service.Spreadsheets.Values.Get(_googleContext.spreadsheetId, _googleContext.range);
                request.ValueRenderOption = SpreadsheetsResource.ValuesResource.GetRequest.ValueRenderOptionEnum.FORMATTEDVALUE;
                var response = request.Execute();
                var list = new List<T>();
                foreach (var row in response.Values)
                {
                    var instance = ((T)Activator.CreateInstance(typeof(T)));
                    for (int i = 0; i < ((List<object>)row).Count; i++)
                    {
                        TypeConverter typeConverter = TypeDescriptor.GetConverter(instance.GetType().GetProperties()[i]);
                        var value = row[i].ToString();
                        if (instance.GetType().GetProperties()[i].PropertyType == typeof(TicketArea))
                        {
                            var formatedValue = Convert.ChangeType(value, typeof(int));
                            var enumValue = (TicketArea)formatedValue;
                            instance.GetType().GetProperty(instance.GetType().GetProperties()[i].Name).SetValue(instance, enumValue);
                        }
                        else if (instance.GetType().GetProperties()[i].PropertyType == typeof(Guid?))
                        {
                            var formatedValue = new Guid(value);
                            instance.GetType().GetProperty(instance.GetType().GetProperties()[i].Name).SetValue(instance, formatedValue);
                        }
                        else
                        {

                            var formatedValue = Convert.ChangeType(value, instance.GetType().GetProperties()[i].PropertyType);
                            instance.GetType().GetProperty(instance.GetType().GetProperties()[i].Name).SetValue(instance, formatedValue);
                        }
                    }

                    list.Add(instance);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

  
        
        public T GetById(Guid entityId, string includeProperties = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includeProperties == null) return query.FirstOrDefault(x => x.Id == entityId);

            query = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, include) => current.Include(include));

            return query.FirstOrDefault(x => x.Id == entityId);
        }

        // Metodos Privados
       
    }
}
