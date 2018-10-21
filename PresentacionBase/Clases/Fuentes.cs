using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionBase.Clases
{
    public static class Fuentes
    {
        public static PrivateFontCollection fuentes = new PrivateFontCollection();

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();

        public static Font NuevaFuente(byte[] fuente, long size)
        {
            byte[] fontData = fuente;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, fuente.Length);
            AddFontMemResourceEx(fontPtr, (uint)fuente.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], size);
        }
    }
}
