using System.Collections.Generic;

namespace ITTWEB_ASPNetCore.Models.AccountViewModels
{
    public class ComponentType
    {
        public ComponentType()
        {
            Components = new HashSet<Component>();
            CategoryComponentTypes = new HashSet<CategoryComponentType>();
        }
        public long ComponentTypeId { get; set; }
        public string ComponentName { get; set; }
        public string ComponentInfo { get; set; }
        public string Location { get; set; }
        public ComponentTypeStatus Status { get; set; }
        public string Datasheet { get; set; }
        public string ImageUrl { get; set; }
        public string Manufacturer { get; set; }
        public string WikiLink { get; set; }
        public string AdminComment { get; set; }
        public virtual ESImage Image { get; set; }
        public ICollection<Component> Components { get;  set; } // TODO: Protected set when using database
        public ICollection<CategoryComponentType> CategoryComponentTypes { get; set; } //TODO: Protected set when using database
    }

    public static class ComponentTypeMock
    {
        public static List<ComponentType> GetComponentTypes()
        {
            return new List<ComponentType>
            {
                new ComponentType() {AdminComment = "AdminComment test 1", ComponentInfo = "Info test 1", ComponentName = "Component name 1", ComponentTypeId = 1, Datasheet = "http://www.w3schools.com/bootstrap/bootstrap_grid_system.asp", Image = ESImageMock.GetEsImage(), ImageUrl = "Image Test URL", Location = "Århus", Manufacturer = "ASE", Status = ComponentTypeStatus.Available, WikiLink = "WIKI TEST", Components = ComponentMock.GetComponents(1)},
                new ComponentType() {AdminComment = "AdminComment test 2", ComponentInfo = "Info test 2", ComponentName = "Component name 2", ComponentTypeId = 2, Datasheet = "http://www.w3schools.com/bootstrap/bootstrap_grid_system.asp", Image = ESImageMock.GetEsImage(), ImageUrl = "Image Test URL", Location = "Århus", Manufacturer = "ASE", Status = ComponentTypeStatus.Available, WikiLink = "WIKI TEST", Components = ComponentMock.GetComponents(2)},
                new ComponentType() {AdminComment = "AdminComment test 3", ComponentInfo = "Info test 3", ComponentName = "Component name 3", ComponentTypeId = 3, Datasheet = "http://www.w3schools.com/bootstrap/bootstrap_grid_system.asp", Image = ESImageMock.GetEsImage(), ImageUrl = "Image Test URL", Location = "Århus", Manufacturer = "ASE", Status = ComponentTypeStatus.Available, WikiLink = "WIKI TEST", Components = ComponentMock.GetComponents(3)},

            };
        }

        public static ComponentType GetComponentType(int number)
        {
            return new ComponentType()
            {
                AdminComment = "AdminComment test " + number,
                ComponentInfo = "Info test " + number,
                ComponentName = "Component name " + number,
                ComponentTypeId = number,
                Datasheet = "http://www.w3schools.com/bootstrap/bootstrap_grid_system.asp",
                Image = ESImageMock.GetEsImage(),
                ImageUrl = "Image Test URL",
                Location = "Århus",
                Manufacturer = "ASE",
                Status = ComponentTypeStatus.Available,
                WikiLink = "WIKI TEST",
                Components = ComponentMock.GetComponents(number)
            };
        }
    }
}