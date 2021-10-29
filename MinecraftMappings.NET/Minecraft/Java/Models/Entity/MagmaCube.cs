using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class MagmaCube : JavaEntityModel
    {
        public MagmaCube() : base("Magma Cube")
        {
            AddVersion("magma_cube", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("segment1", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 7f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("segment2", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(0f, 1f),
                    });
                })
                .AddElement("segment3", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 5f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(24f, 10f),
                    });
                })
                .AddElement("segment4", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 4f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(24f, 19f),
                    });
                })
                .AddElement("segment5", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 3f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(0f, 4f),
                    });
                })
                .AddElement("segment6", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 2f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(0f, 5f),
                    });
                })
                .AddElement("segment7", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 1f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(0f, 6f),
                    });
                })
                .AddElement("segment8", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -4f),
                        Size = new Vector3(8f, 1f, 8f),
                        UV = new Vector2(0f, 7f),
                    });
                })
                .AddElement("core", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 2f, -2f),
                        Size = new Vector3(4f, 4f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
