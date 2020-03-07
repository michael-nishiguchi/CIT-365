using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Nishiguchi {
    class Desk {

        float width;
        float depth;
        int drawerNumber;
        String material;
        int shippingDays;

        public Desk() {

        }
        public enum SurfaceMaterial {

            Laminate = 1,
            Oak = 2,
            Rosewood = 3,
            Veneer = 4,
            Pine = 5
        };

        public float Width { get => width; set => width = value; }
        public float Depth { get => depth; set => depth = value; }
        public int DrawerNumber { get => drawerNumber; set => drawerNumber = value; }
        public string Material { get => material; set => material = value; }
        public int ShippingDays { get => shippingDays; set => shippingDays = value; }
        public float SurfaceArea { get => surfaceArea; set => surfaceArea = value; }

        private float surfaceArea;
        internal void getArea() {
            this.SurfaceArea = this.Width * this.Depth;
        }
    }
}
