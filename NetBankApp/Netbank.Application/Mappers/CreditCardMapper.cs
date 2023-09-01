using NetBank.Domain.Common;
using NetBank.Domain.Dto;
using NetBank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netbank.Application.Mappers
{
    public static class CreditCardMapper
    {

        public static IssuingNetworkData ConvertToNetworkData(IssuingNetwork network)
        {
            return new IssuingNetworkData
            {
                Name = network.Name,
                StartsWithNumbers = DataTransformer.ComaSeparatedValuesToIntList(network.StartsWithNumbers),
                InRange = DataTransformer.HyphenSeparatedValuesToRangeNumber(network.InRange),
                AllowedLengths = DataTransformer.ComaSeparatedValuesToIntList(network.AllowedLengths)
            };
        }

        public static List<IssuingNetworkData> ConvertToNetworkDataList(IEnumerable<IssuingNetwork> networks)
        {
            return networks.Select(ConvertToNetworkData).ToList();
        }
    }
}