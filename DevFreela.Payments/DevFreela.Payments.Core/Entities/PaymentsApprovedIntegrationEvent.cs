namespace DevFreela.Payments.Core.Entities
{
    public class PaymentsApprovedIntegrationEvent
    {
        public PaymentsApprovedIntegrationEvent(int idProject)
        {
            IdProject = idProject;
        }

        public int IdProject { get; set; }
    }
}
