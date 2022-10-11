using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsLogic.Models
{
    [FirestoreData]
    public class RackModel
    {
        [FirestoreProperty]
        public double Temperatura { get; set; }
        [FirestoreProperty]
        public double Humedad { get; set; }
        [FirestoreProperty]
        public bool Puertas { get; set; }
        [FirestoreProperty]
        public bool Energia { get; set; }
        [FirestoreProperty]
        public bool Luz { get; set; }
    }
}
