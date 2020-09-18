using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace ClienteHospitalFirebase
{
    [FirestoreData]
    class Enfermedad
    {

        [FirestoreProperty]
        public int Codigo { get; set; }
        [FirestoreProperty]
        public string Nombre { get; set; }
        [FirestoreProperty]
        public string Tipo { get; set; }
        
    }
}
