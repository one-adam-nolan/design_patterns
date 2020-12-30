namespace Starbuzz.Domain.Abstract
{
    public abstract class Beverage
    {
        protected string Description { get; set; }

        public virtual string GetDescription() => this.Description;

        public abstract decimal Cost();
    }
}
