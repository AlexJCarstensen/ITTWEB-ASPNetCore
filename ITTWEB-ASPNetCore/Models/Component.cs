using System.Collections.Generic;

namespace ITTWEB_ASPNetCore.Models.AccountViewModels
{
    public class Component
    {
        public long ComponentId { get; set; }
        public long ComponentTypeId { get; set; }
        public int ComponentNumber { get; set; }
        public string SerialNo { get; set; }
        public ComponentStatus Status { get; set; }
        public string AdminComment { get; set; }
        public string UserComment { get; set; }
        public long? CurrentLoanInformationId { get; set; }
    }

    public static class ComponentMock
    {
        public static List<Component> GetComponents(int componentTypeId)
        {
            return new List<Component>
            {
                new Component()
                {
                    ComponentId = 1,
                    ComponentTypeId = componentTypeId,
                    Status = ComponentStatus.Available,
                    AdminComment = "Admin comment 1",
                    ComponentNumber = 1,
                    CurrentLoanInformationId = 1,
                    SerialNo = "Serial number 1",
                    UserComment = "It works (User comment 1)"
                },
                new Component()
                {
                    ComponentId = 2,
                    ComponentTypeId = componentTypeId,
                    Status = ComponentStatus.Available,
                    AdminComment = "Admin comment 2",
                    ComponentNumber = 2,
                    CurrentLoanInformationId = 1,
                    SerialNo = "Serial number 2",
                    UserComment = "It works (User comment 2)"
                },
                new Component()
                {
                    ComponentId = 3,
                    ComponentTypeId = componentTypeId,
                    Status = ComponentStatus.Available,
                    AdminComment = "Admin comment 3",
                    ComponentNumber = 3,
                    CurrentLoanInformationId = 1,
                    SerialNo = "Serial number 3",
                    UserComment = "It works (User comment 3)"
                },

            };

        }
    }
}