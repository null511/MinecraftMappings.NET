using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Banner : JavaEntityModel
    {
        public Banner() : base("Banner")
        {
            AddVersion("banner", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("top", element => {
                    element.Translate = new Vector3(0f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-10f, 42f, -1f),
                        Size = new Vector3(20f, 2f, 2f),
                        UV = new Vector2(0f, 42f),
                    });
                })
                .AddElement("slate", element => {
                    element.Translate = new Vector3(0f, -44f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-10f, 4f, -2f),
                        Size = new Vector3(20f, 40f, 1f),
                    });
                })
                .AddElement("stand", element => {
                    element.Translate = new Vector3(0f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, -1f),
                        Size = new Vector3(2f, 42f, 2f),
                        UV = new Vector2(44f, 0f),
                    });
                });
        }
    }
}
