namespace MinecraftMappings.Internal.Models.Entity
{
    public abstract class JavaEntityModel : EntityModel<JavaEntityDataVersion>
    {
        protected JavaEntityModel(string name) : base(name) {}
    }

    public class JavaEntityDataVersion : EntityModelVersion {}
}
