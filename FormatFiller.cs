using System;
using System.Text;

namespace ZPLSharp
{

    public class ZPLFormatFiller
    {
        StringBuilder Filler = new StringBuilder();

        public ZPLFormatFiller()
        {

        }

        public StringBuilder GetFiller()
        {
            return Filler;
        }

        public void FillField(int FieldNumber, string FillerText)
        {
            Filler.Append($"^FN{FieldNumber}^FD{FillerText}^FS");
        }

    }
}