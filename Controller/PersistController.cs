using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PersistController
    {
        private PersistService _service;
        public PersistController()
        {
            _service = new PersistService();
        }
        public bool Insert(List<Infracao> infracoes)
        {
            
            return _service.Insert(infracoes);
        }
        public List<Infracao> GetAll() { return _service.GetAll(); }
    }
}