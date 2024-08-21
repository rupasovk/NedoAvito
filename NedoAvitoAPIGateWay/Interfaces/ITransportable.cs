using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.Interfaces
{
    public interface ITransportable<T>
    {
        public T GetFromDto(IDataTransportObject _dto);
        
        public IDataTransportObject TranslateToDto();
    }
}
