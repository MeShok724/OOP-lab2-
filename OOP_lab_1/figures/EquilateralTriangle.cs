﻿using System.Drawing;

namespace OOP_lab_1
{
    public class EquilateralTriangle : DisplayObject
    {
        private readonly int _width;
        override public void Draw(Graphics g)
        {
            using (var pen = new Pen(_borderColor, _borderSize * 2))
            {
                using (var brush = new SolidBrush(_fillColor))
                {
                    g.DrawPolygon(pen, new []{ new Point(_pos.x + _width/2, _pos.y), new Point(_pos.x, _pos.y + _width), new Point(_pos.x + _width, _pos.y + _width) });
                    g.FillPolygon(brush,new []{ new Point(_pos.x + _width/2, _pos.y), new Point(_pos.x, _pos.y + _width), new Point(_pos.x + _width, _pos.y + _width) });
                }
            }
        }
        
        public EquilateralTriangle(MyPoint pos, Color fillColor, Color borderColor, int borderSize, int width) : base(pos, fillColor, borderColor, borderSize)
        {
            condRect.posStart.x = pos.x - _borderSize;
            condRect.posStart.y = pos.y - _borderSize;
            condRect.posEnd.x = pos.x + width + _borderSize;
            condRect.posEnd.y = pos.y + width + _borderSize;
            _width = width;
        }
    }
}