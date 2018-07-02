## Summary

When moving between scenes and instantiate large count of prefabs, memory incresed uncontrollably and with noticable spikes, despite of manual cleanup (GC.Collect/Resources.UnloadUnusedAssets). You can find simple repro logics in [Test.cs](https://github.com/KonH/UnityMemoryIssue/blob/master/Assets/Test.cs). 

## Details:

- **Unity versions:** Unity 2017.3.1p1, 2017.4.6f1, 2018.1.6f1
- **Platform:** iOS
- **Affected devices:** iPhone X (iOS 11.3), iPad Air 2 (iOS 11.2)

## Steps to reproduce:

- Build project and run it on device via Xcode
- Wait some time and observe memory usage
- Memory usage incresed to big values (like 1+ Gb)
- App will be crashed or terminated with "memory pressure" message

## Sample:

### Memory increased with noticable spikes:

![memory_1](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/memory_1.png?raw=true)
![memory_2](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/memory_2.png?raw=true)
![memory_3](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/memory_3.png?raw=true)
![memory_4](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/memory_4.png?raw=true)
![memory_5](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/memory_5.png?raw=true)

## Then app crashed:

After 1k iterations:
![log](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/log.png?raw=true)

With given traces:
![stacktrace](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/stacktrace.png?raw=true)
![crash](https://github.com/KonH/UnityMemoryIssue/blob/master/Images/crash.png?raw=true)
