using System.Collections.Generic;

namespace CelticEgyptianRatscrewKata
{
    public class SnapValidator
    {
        private readonly IEnumerable<IRule> m_Rules;

        public SnapValidator(IEnumerable<IRule> rules)
        {
            m_Rules = rules;
        }

        public bool CanSnap(Stack stack)
        {
            return false;
        }
    }
}