# Barrage Demo introduction
1: Supports forwarding of bullet screens from multiple live streaming platforms at the same time    
2: The forwarding software can be deployed separately, not on the same machine, to share the pressure    
3: The plug-in itself, multi-threaded, asynchronous mode does not block, game thread, high efficiency     
4: Added processing for forwarded bullet screens    
5: Very simple and easy to use, just one interface    
6: Currently supports Douyin bullet screen    
1：同时支持多个直播平台的弹幕的转发    
2：可以分开转发软件的部署， 不在同一个机器，分摊压力   
3：插件自身，多线程，异步方式不阻塞，game thread ，效率高   
4：添加了对转发的弹幕的处理      
5：非常简单易用，就一个接口    
6：目前暂时支持 抖音弹幕   
抖音弹幕The implementation method is that other open source software forwards the barrage information to this plugin, and then the plugin processes the information.     
[虚幻商场插件 链接 LINK for plugin in Unreal Market](https://www.fab.com/zh-cn/portal/listings/097fe3a0-b42e-4b6c-abf4-e9b4180948c0)   

# step 0, Douyin 抖音使用的转发工具是这个       
https://github.com/skmcj/dycast

# step 1, Create Barrage Instance,       
![image](https://github.com/user-attachments/assets/43310e1c-5734-427c-b1a9-3bd3a52a8f7c)        

# Step 2, Bind function call back when receive message from Douyin:      
![image](https://github.com/user-attachments/assets/56423224-959e-48bb-a556-41b5ca15a3e0)       
# step 3, use the same port as we created in our plugin:           
![image](https://github.com/user-attachments/assets/1010b2cb-d70f-4363-82ca-a442fa955cac)

# Step 4, we can print all barrage message on screen:      
![image](https://github.com/user-attachments/assets/4fd76673-eafe-4270-a34a-766e00987986)      
![image](https://github.com/user-attachments/assets/83bce947-8927-4365-aec0-6c5e1fd37751)     

