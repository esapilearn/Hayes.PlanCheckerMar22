using ESAPIX.Constraints;
using Prism.Mvvm;

namespace ESAPX_StarterUI.ViewModels
{
    public class PlanConstraint : BindableBase
        // Planconstraint is inherited fromthe BindableBase (this is what the : is doing/saying)
    {
        public PlanConstraint(IConstraint con)
        {
            this.Constraint = con;
        }

        private IConstraint _constraint;
        public IConstraint Constraint
        {
            get { return _constraint; }
            set { SetProperty(ref _constraint, value); }
        }

        private ConstraintResult _result;
        public ConstraintResult Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }
    }
}