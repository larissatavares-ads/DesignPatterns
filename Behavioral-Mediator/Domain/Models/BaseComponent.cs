﻿using Behavioral_Mediator.Interfaces;

namespace Behavioral_Mediator.Domain.Models
{
    class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
