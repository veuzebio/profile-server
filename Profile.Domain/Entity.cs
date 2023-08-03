using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain
{
    /// <summary>
    /// Abstract class that provides the model identifier.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Model identifier.
        /// </summary>
        public Guid Id { get; protected set; }
    }
}
