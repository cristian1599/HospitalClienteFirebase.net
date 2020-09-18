using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteHospitalFirebase
{
    [FirestoreData]
    class Historial
    {
        [FirestoreProperty]
        public int numero_historia { get; set; }
        [FirestoreProperty]
        public string documento_paciente { get; set; }
        [FirestoreProperty]
        public string nombre_doctor { get; set; }
        [FirestoreProperty]
        public int codigo_enfermedad { get; set; }
    }
}
