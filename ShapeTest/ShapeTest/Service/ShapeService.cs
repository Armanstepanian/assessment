
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ShapeTest.Core.IService;
using ShapeTest.Model;
using ShapeTest.ShapeHelper;

namespace ShapeTest.Service
{
    public class ShapeService : IShapeService
    {
        #region "Ctor"
        public ShapeService()
        {
        }
        #endregion "Ctor"
        public async Task<double> GetCirculeArea(double radius)
        {
            Circle circle = new Circle(radius);
            return circle.GetArea;
            //return Math.PI * radius * radius;
        }
        public async Task<double> GetTriangleArea(shapeModels model)
        {
            Triangle triangle = new Triangle(model.SideA,model.SideB,model.SideC);
            return triangle.GetArea;
            //double p = (model.SideA + model.SideB + model.SideC) / 2;
            //return Math.Sqrt(p * (p - model.SideA) * (p - model.SideB) * (p - model.SideC));
        }
    }
}
