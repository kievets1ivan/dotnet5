using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public enum Complexity : byte
    {
        Low = 1,
        LowMiddle = 2,
        Middle = 3,
        MiddleHigh = 4,
        High = 5
    }
    public abstract class Task
    {
        protected float PlanDuration { get; set; }
        protected float Duration() { return (PlanDuration + ((byte)Complex * 10 / 100)) * Priority; }

        protected string Name { get; set; }
        protected float Priority { get; set; }
        public Complexity Complex;

        public Task(string name, Complexity complexity, float planDuration)
        {
            Name = name;
            Complex = complexity;
            PlanDuration = planDuration;
        }

    }


    public class Bag : Task
    {
        public Bag(string name, Complexity complexity, float planDuration) : base(name, complexity, planDuration)
        {
            Priority = 2;
        }


    }
    public class Feature : Task
    {
        public Feature(string name, Complexity complexity, float planDuration) : base(name, complexity, planDuration)
        {
            Priority = 1;
        }


    }

    public class TechDebt : Task
    {
        public TechDebt(string name, Complexity complexity, float planDuration) : base(name, complexity, planDuration)
        {
            Priority = 0.5f;
        }


    }
}
