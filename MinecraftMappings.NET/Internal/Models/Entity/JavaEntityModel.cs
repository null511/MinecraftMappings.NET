namespace MinecraftMappings.Internal.Models.Entity
{
    public abstract class JavaEntityModel : EntityModel<JavaEntityModelVersion>
    {
        protected JavaEntityModel(string name) : base(name) {}
    }

    public class JavaEntityModelVersion : EntityModelVersion {}
}
