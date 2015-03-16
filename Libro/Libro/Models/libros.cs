using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro.Models
{
    public  class Libros
    {

        private ObservableCollection<Libro> data;

        public ObservableCollection<Libro> Data {
            get
            {
                if (data == null) {
                    data = new ObservableCollection<Libro>();
                    Libro Libro1 = new Libro()
                    {
                        Nombre= "Padre ri",
                        Autor="as",
                        Codigo="dvr",
                        Genero="comedia",
                        Paginas=300

                    };

                    Libro Libro2 = new Libro()
                    {
                        Nombre = "Padre po",
                        Autor = "by",
                        Codigo = "dvre",
                        Genero = "terror",
                        Paginas = 150

                    };

                    Libro Libro3 = new Libro()
                    {
                        Nombre = "Padre me",
                        Autor = "el",
                        Codigo = "dvrr",
                        Genero = "otaku",
                        Paginas = 90

                    };
                    data.Add(Libro1);
                    data.Add(Libro2);
                    data.Add(Libro3);
                   
                
                
                }


                return data;
            
            }

            set {

                data = value;
            }
        
        }

    }
}
