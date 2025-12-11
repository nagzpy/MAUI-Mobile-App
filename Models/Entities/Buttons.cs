using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.Models.Entities
{
    public static class Buttons
    {
        public static ImageSource IconsEdit { get; } = ImageSource.FromFile("edit.png");
        public static ImageSource IconsDelete { get; } = ImageSource.FromFile("delete.png");
    }
}
