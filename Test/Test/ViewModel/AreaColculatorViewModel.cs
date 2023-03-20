using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Test.ViewModel.AreaColculatorViewModel
{
public class AreaColculatorViewModel : INotifyPropertyChanged
    {
        #region propertys
        double aSide;
        double bSide;
        double cSide;
        double radius;
        double triangleArea;
        double shapeArea;
        public double ASide
        {
            get { return aSide; }
            set
            {
                aSide = value;
                OnPropertyChanged("ASide");
                triangleAreaCountAsync();
            }
        }
        public double BSide
        {
            get { return bSide; }
            set
            {
                bSide = value;
                OnPropertyChanged("BSide");
                triangleAreaCountAsync();
            }
        }
        public double CSide
        {
            get { return cSide; }
            set
            {
                cSide = value;
                OnPropertyChanged("CSide");
                triangleAreaCountAsync();
            }
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                OnPropertyChanged("Radius");
                ShapeAreaCountAsync();
            }
        }
        public double ShapeArea
        {
            get { return shapeArea; }
            set
            {
                shapeArea = value;
                OnPropertyChanged("ShapeArea");
            }
        }
        public double TriangleArea
        {
            get { return triangleArea; }
            set
            {
                triangleArea = value;
                OnPropertyChanged("TriangleArea");
            }
        }
        #endregion propertys
        #region methods 
        public async Task triangleAreaCountAsync() 
       {
            if ((aSide > 0 && bSide > 0 && cSide > 0) && ((aSide + bSide > cSide) || (aSide + cSide > aSide) || (cSide + bSide > aSide)))
            {

                double p = (aSide + bSide + cSide) / 2;
                TriangleArea = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
                OnPropertyChanged("TriangleArea");
            }
        }
        public async Task ShapeAreaCountAsync()
        {
            if (radius > 0)
            {

                ShapeArea = Math.PI * radius * radius;
                OnPropertyChanged("ShapeArea");
            }
        }
        #endregion methods
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
