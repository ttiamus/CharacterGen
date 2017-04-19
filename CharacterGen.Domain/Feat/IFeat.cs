using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CharacterGen.Domain.Feat
{
    public interface IFeat
    {
        void UpdateName(string name);
        void UpdateDescription(string description);
        void UpdateBenefits(IEnumerable<string> benefits);
    }
}