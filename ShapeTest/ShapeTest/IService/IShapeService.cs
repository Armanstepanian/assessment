using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeTest.Model;

namespace ShapeTest.Core.IService
{
    internal interface IShapeService
    {
        Task<double> GetCirculeArea(double radius);
        Task<double> GetTriangleArea(shapeModels moldel);
    }
}
