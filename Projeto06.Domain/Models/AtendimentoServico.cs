using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Domain.Models
{
    public class AtendimentoServico
    {
        #region Propriedades

        // NAO CRIAR PK AQUI. O ENTITY FAZ A MANUTENCAO DESTA TABELA (I/A/E)
        public Guid AtendimentoId { get; set; }
        public Guid ServicoId { get; set; }

        #endregion

        #region Associações

        public Atendimento? Atendimento { get; set; }
        public Servico? Servico { get; set; }

        #endregion
    }
}
