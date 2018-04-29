using System.Collections.Generic;

namespace Prey_Predator
{
    public interface IPredator
    {
        List<IPrey> Chase(List<IPrey> ipreyList);
        void Eat(List<IPrey> preys);
        double Distance(IPrey iPrey);
        IPredator Breed();

        bool Starving { get; }
    }
}