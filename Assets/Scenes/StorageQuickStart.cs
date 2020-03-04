using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using LeanCloud;
using LeanCloud.Storage;
using LeanCloud.Common;

public class StorageQuickStart : MonoBehaviour {
    private void Awake() {
        LeanCloud.Logger.LogDelegate += Print;
        LeanCloud.LeanCloud.Initialize("ikGGdRE2YcVOemAaRbgp1xGJ-gzGzoHsz", "NUKmuRbdAhg1vrb2wexYo1jo", "https://ikggdre2.lc-cn-n1-shared.com");
    }

    private void OnDestroy() {
        LeanCloud.Logger.LogDelegate -= Print;
    }

    // Start is called before the first frame update
    void Start() {
        Login();
    }

    async Task Login() {
        await LCUser.Login("hello", "world");
    }

    void Print(LogLevel level, string message) {
        switch (level) {
            case LogLevel.Debug:
                Debug.Log(message);
                break;
            case LogLevel.Warn:
                Debug.LogWarning(message);
                break;
            case LogLevel.Error:
                Debug.LogError(message);
                break;
            default:
                break;
        }
        
    }
}
