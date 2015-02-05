﻿using System.Collections.Generic;
using System.Linq;

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
            return m_Rules.Any(rule => rule.ContainsSnap(stack));
        }
    }
}