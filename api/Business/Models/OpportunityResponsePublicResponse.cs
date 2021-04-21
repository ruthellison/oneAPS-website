using System;

namespace Dta.OneAps.Api.Business.Models {
    public class OpportunityResponsePublicResponse {
        public int Id { get; set; }
        public int OpportunityId { get; set; }
        public OpportunityPublicResponse Opportunity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? WithdrawnAt { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
