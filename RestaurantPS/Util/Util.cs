using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPS.Util
{
    class Util
    {
        public static Rol getRol(string input)
        {
            Rol rol = Rol.UNDEF;
            switch (input)
            {
                case "ADMIN":
                    rol = Rol.ADMIN;
                    break;
                case "ANGAJAT":
                    rol = Rol.ANGAJAT;
                    break;
                default:
                    rol = Rol.UNDEF;
                    break;
            }
            return rol;
        }
        public static Status GetStatus(string input)
        {
            Status status = Status.UNDEF;
            switch (input)
            {
                case "FINALIZATA":
                    status = Status.FINALIZATA;
                    break;
                case "PREPARARE":
                    status = Status.PREPARARE;
                    break;
                case "NOUA":
                    status = Status.NOUA;
                    break;
                default:
                    status = Status.UNDEF;
                    break;
            }
            return status;
        }
    }
}
