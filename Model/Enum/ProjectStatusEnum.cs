using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Model.Enum
{
    /// <summary>
    /// Enum referente ao Status do projeto
    /// </summary>
    public enum ProjectStatusEnum
    {
        /// <summary>
        /// 0 - Em desenvolvimento
        /// </summary>
        [Description("Em desenvolvimento")] EmDesenvolvimento,
        /// <summary>
        /// 1 - Publicado
        /// </summary>
        [Description("Publicado")] Publicado
    }
}
