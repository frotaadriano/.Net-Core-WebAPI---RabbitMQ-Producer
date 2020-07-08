using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComsumoRabbitMQ
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Descricao{ get; set; }

        public int Prioridade { get; set; }
    }
}
