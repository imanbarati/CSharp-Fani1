using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdMobile_Class_DataGridView
{
    class Id
    {
        decimal id_mobile, year_pu;
        string name, color, systemw, model;
        public Id(decimal Id_mobile, decimal Year_pu, string Name, string Color, string Systemw, string Model)
        {
            id_mobile=Id_mobile;
            year_pu=Year_pu;
            name = Name;
            color=Color;
            systemw = Systemw;
            model = Model;
        }
        public decimal Id_mobile
        {
            get { return id_mobile; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public decimal Year_pu
        {
            get { return year_pu; }
            set { year_pu = value; }
        }
        public string Systemw
        {
            get { return systemw; }
            set { systemw = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
