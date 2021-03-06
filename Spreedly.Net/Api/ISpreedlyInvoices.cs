﻿namespace Spreedly.Api
{
    using Spreedly.Client;
    using Spreedly.Entities;

    public interface ISpreedlyInvoices
    {
        SpreedlyResponse<Invoice> CreateInvoice(Invoice invoice);
        SpreedlyResponse<Invoice> PayInvoice(Invoice invoice, Payment payment);
    }
}