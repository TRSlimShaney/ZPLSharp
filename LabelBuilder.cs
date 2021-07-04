using System;
using System.Text;
using System.Collections.Generic;
using ZPLSharp.Commands;

namespace ZPLSharp
{

    public class ZPLLabelBuilder
    {
        StringBuilder Label = new StringBuilder();
        int XYScaler;
        int NumberOfFields = 0;

        public ZPLLabelBuilder(int XYScaler)
        {
            this.XYScaler = XYScaler;
        }

        public ZPLLabelBuilder()
        {
            this.XYScaler = 1;
        }

        public StringBuilder GetLabel()
        {
            return Label;
        }

        public void AddText(int XCor, int YCor, ZPLFont Font, ZPLOrientation Orientation, int FontHeight, int FontWidth, string Text)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            FontHeight *= XYScaler;
            FontWidth *= XYScaler;

            Label.Append(ZPLCommands.AddText(XCor, YCor, Font, Orientation, FontHeight, FontWidth, Text));
        }

        public int AddField(int XCor, int YCor, ZPLFont Font, ZPLOrientation Orientation, int FontHeight, int FontWidth, int FieldLength)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            FontHeight *= XYScaler;
            FontWidth *= XYScaler;
            ++NumberOfFields;

            Label.Append(ZPLCommands.AddField(XCor, YCor, Font, Orientation, FontHeight, FontWidth, NumberOfFields, FieldLength));
            return NumberOfFields;
        }

        public void AddBox(int XCor, int YCor, int Width, int Height, int BorderThickness, int ZeroToEightRounding, ZPLColor Color)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            Height *= XYScaler;
            BorderThickness *= XYScaler;

            Label.Append(ZPLCommands.AddBox(XCor, YCor, Width, Height, BorderThickness, ZeroToEightRounding, Color));
        }

        public void AddCircle(int XCor, int YCor, int Diameter, int BorderThickness)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            Diameter *= XYScaler;
            BorderThickness *= XYScaler;

            Label.Append(ZPLCommands.AddCircle(XCor, YCor, Diameter, BorderThickness));
        }

        public void AddDiagonalLine(int XCor, int YCor, int Width, int Height, int BorderThickness, ZPLColor Color, ZPLLineOrientation Orientation)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            Width *= Width;
            Height *= Height;
            BorderThickness *= XYScaler;

            Label.Append(ZPLCommands.AddDiagonalLine(XCor, YCor, Width, Height, BorderThickness, Color, Orientation));
        }

        public void AddEllipse(int XCor, int YCor, int Width, int Height, int BorderThickness, ZPLColor Color)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            Width *= Width;
            Height *= Height;
            BorderThickness *= XYScaler;

            Label.Append(ZPLCommands.AddEllipse(XCor, YCor, Width, Height, BorderThickness, Color));
        }

        public void AddGraphic(int XCor, int YCor, ZPLLocation Location, string GraphicName, int XZoom, int YZoom)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;

            Label.Append(ZPLCommands.AddGraphic(XCor, YCor, Location, GraphicName, XZoom, YZoom));
        }

        public void AddSymbol(int XCor, int YCor, ZPLSymbol Symbol)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;

            Label.Append(ZPLCommands.AddSymbol(XCor, YCor, Symbol));
        }

        public void AddBarCode128(int XCor, int YCor, ZPLOrientation Orientation, int Height, bool PrintInterpretationLine, bool PrintInterpretationLineAboveCode, bool UCCCheckDigit, string Text)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;
            Height *= XYScaler;

            Label.Append(ZPLCommands.AddBarCode128(XCor, YCor, Orientation, Height, PrintInterpretationLine, PrintInterpretationLineAboveCode, UCCCheckDigit, Text));
        }

        public void AddSquareDataMatrix(int XCor, int YCor, ZPLOrientation Orientation, int RowsAndCols, string Text)
        {
            XCor *= XYScaler;
            YCor *= XYScaler;

            Label.Append(ZPLCommands.AddSquareDataMatrix(XCor, YCor, Orientation, RowsAndCols, Text));
        }

    }
}