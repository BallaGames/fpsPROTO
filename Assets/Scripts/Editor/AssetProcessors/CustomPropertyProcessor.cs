using UnityEngine;
using UnityEditor;
using UnityEngine.NVIDIA;
namespace Balla
{
    public class CustomPropertyProcessor : AssetPostprocessor
    {

        static readonly uint version = 0;
        public override uint GetVersion() => version;

        private void OnPostprocessGameObjectWithAnimatedUserProperties(GameObject gameObject, EditorCurveBinding[] bindings)
        {
            if(bindings.Length == 0)
            {
                Debug.Log("no bindings found...");
            }
            else
            {
                Debug.Log("fuck yeah, bindings!!!!");
            }
                //for (int i = 0; i < bindings.Length; i++)
                //{
                //    Debug.Log("checking binding with name " + bindings[i].propertyName);
                //    if (bindings[i].propertyName.ToLower().Contains("weight"))
                //    {
                //        Debug.Log("Found a hand weight!");
                //        if (!gameObject.TryGetComponent(out CustomPropertyWeighter propWeighter))
                //        {
                //            propWeighter = gameObject.AddComponent<CustomPropertyWeighter>();
                //        }
                //        if (!propWeighter.propertyWeight.ContainsKey(bindings[i].propertyName))
                //        {
                //            propWeighter.propertyWeight.Add(bindings[i].propertyName, 0);

                //        }
                //        string oldPropName = bindings[i].propertyName;
                //        bindings[i].propertyName = $"propertyWeight[{oldPropName}]";
                //        bindings[i].path = AnimationUtility.CalculateTransformPath(gameObject.transform, gameObject.transform.root);
                //        bindings[i].type = typeof(CustomPropertyWeighter);

                    
                //    }
                //}
        }
        private void OnPostprocessGameObjectWithUserProperties(GameObject gameObject, string[] propNames, object[] values)
        {
            if(propNames.Length == 0)
            {
                Debug.Log($"Found no regular properties on this object", gameObject);
            }
            else
            {
                for (int i = 0; i < propNames.Length; i++)
                {
                    Debug.Log($"Found properties on this object - {propNames[i]}", gameObject);
                }
            }
        }
        public CustomPropertyProcessor()
        {
        }
    }
}
