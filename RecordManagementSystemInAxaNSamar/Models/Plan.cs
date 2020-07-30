using System.Collections.Generic;

namespace RecordManagementSystemInAxaNSamar.Model
{
    public class Plan
    {
        public int PlanId { get; internal set; }
        public string PlanName { get; set; }
        public string PlanType { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }



        public ICollection<ClientPlan> ClientPlans { get; set; }
    }
}