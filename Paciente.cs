using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
namespace ClienteHospitalFirebase
{
    [FirestoreData]
    class Paciente
    {
        [FirestoreProperty]
        public string documento { get; set; }
        [FirestoreProperty]
        public string nombre { get; set; }
        [FirestoreProperty]
        public string correo { get; set; }
        [FirestoreProperty]
        public string telefono { get; set; }
        [FirestoreProperty]
        public string genero { get; set; }

    }
}
