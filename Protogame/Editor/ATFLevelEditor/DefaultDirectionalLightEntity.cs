﻿using Microsoft.Xna.Framework;
using Protogame.ATFLevelEditor;

namespace Protogame
{
    public class DefaultDirectionalLightEntity : ComponentizedEntity
    {
        public DefaultDirectionalLightEntity(
            IEditorQuery<DefaultDirectionalLightEntity> editorQuery,
            StandardDirectionalLightComponent standardDirectionalLightComponent)
        {
            if (editorQuery.Mode != EditorQueryMode.BakingSchema)
            {
                RegisterComponent(standardDirectionalLightComponent);

                editorQuery.MapTransform(this, Transform.Assign);
                editorQuery.MapCustom(this, "direction", "direction", x => standardDirectionalLightComponent.LightDirection = x, Vector3.One);
                editorQuery.MapCustom(this, "diffuse", "diffuse", x => standardDirectionalLightComponent.LightColor = x, Color.White);
            }
        }
    }
}
