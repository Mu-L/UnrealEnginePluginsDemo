# SurfaceAIDemo
plugin link 插件链接:   
[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/zh-CN/product/primitive-draw-line-geometry)  
[LINK for plugin in Fab](https://www.unrealengine.com/marketplace/zh-CN/product/primitive-draw-line-geometry)  
[视频教程 1 链接](https://www.bilibili.com/video/BV1dM411a7Q2/?share_source=copy_web&vd_source=74c5a7ee7e63695eed9e0f75ba7bbc88)  
[video tutorial 1 LINK](https://youtu.be/VzpxfjglunM)  

# Generate Surface Data:    
## 1: Enable SurfaceAI plugin:    
<img width="1780" height="221" alt="image" src="https://github.com/user-attachments/assets/52ab357b-6dc8-49c6-bb98-e8511866e44d" />    
## 2: choose all meshes you want to have the ability for pathfinding , by using mouse left click :     
<img width="3584" height="1659" alt="image" src="https://github.com/user-attachments/assets/7af77877-e088-43dd-b44e-7434435794b0" />
## 3: in Windows, will have a button to generate surface pathing data:      
<img width="1659" height="1819" alt="image" src="https://github.com/user-attachments/assets/fff67cf4-ca97-47ae-a184-6700752f8a61" />      
### 3.1: set all data you want for the pathfinding :    
<img width="849" height="700" alt="image" src="https://github.com/user-attachments/assets/26d965ee-ac39-4687-ad05-27e9ba753866" />     
## 4: click Generate , the data will be generated in “/All/Game/SurfaceNavGraphs”      
<img width="2210" height="1348" alt="image" src="https://github.com/user-attachments/assets/ffba5369-a0e9-4b8c-92eb-23e6b8646aab" />      
## 5: you can debug the data for pathfinding, by right click the generated data:    
<img width="1754" height="1551" alt="image" src="https://github.com/user-attachments/assets/23cfc006-8609-4e79-8bf9-61c918428420" />      
<img width="2237" height="1517" alt="image" src="https://github.com/user-attachments/assets/110da2fe-1b88-46d2-892b-8c088f44d683" />      

# Using SurfaceAI Component:    
## 1: create Surface AI Component in Actor which you want to give ability of SurfaceAI :    
<img width="816" height="756" alt="image" src="https://github.com/user-attachments/assets/df029504-9f96-4024-9dba-0842c482cbff" />      
## 2: fill the surface pathfinding data for the actor:      
<img width="3754" height="1908" alt="image" src="https://github.com/user-attachments/assets/36a4b1a2-54c9-4336-a317-50b18b41448e" />     
## 3: use Surface Pathfinding to get the path in Surface:    
<img width="532" height="592" alt="image" src="https://github.com/user-attachments/assets/7c47e8ce-5fd9-4e14-83f0-9de2eeb87567" />
start Pos: is the position the actor start moving     
End Pos: is the position the actor End moving     
if return false, means the Start Position and End Position you filled is not reachable     
## 4: you can draw the path for debuging :    # SurfaceAIDemo
plugin link 插件链接:   
[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/zh-CN/product/primitive-draw-line-geometry)  
[LINK for plugin in Fab](https://www.unrealengine.com/marketplace/zh-CN/product/primitive-draw-line-geometry)  
[视频教程 1 链接](https://www.bilibili.com/video/BV1dM411a7Q2/?share_source=copy_web&vd_source=74c5a7ee7e63695eed9e0f75ba7bbc88)  
[video tutorial 1 LINK](https://youtu.be/VzpxfjglunM)  


# Generate Surface Data:    
## 1: Enable SurfaceAI plugin:    
<img width="1780" height="221" alt="image" src="https://github.com/user-attachments/assets/52ab357b-6dc8-49c6-bb98-e8511866e44d" />    
## 2: choose all meshes you want to have the ability for pathfinding , by using mouse left click :     
<img width="3584" height="1659" alt="image" src="https://github.com/user-attachments/assets/7af77877-e088-43dd-b44e-7434435794b0" />
## 3: in Windows, will have a button to generate surface pathing data:      
<img width="1659" height="1819" alt="image" src="https://github.com/user-attachments/assets/fff67cf4-ca97-47ae-a184-6700752f8a61" />      
### 3.1: set all data you want for the pathfinding :    
<img width="849" height="700" alt="image" src="https://github.com/user-attachments/assets/26d965ee-ac39-4687-ad05-27e9ba753866" />     
## 4: click Generate , the data will be generated in “/All/Game/SurfaceNavGraphs”      
<img width="2210" height="1348" alt="image" src="https://github.com/user-attachments/assets/ffba5369-a0e9-4b8c-92eb-23e6b8646aab" />      
## 5: you can debug the data for pathfinding, by right click the generated data:    
<img width="1754" height="1551" alt="image" src="https://github.com/user-attachments/assets/23cfc006-8609-4e79-8bf9-61c918428420" />      
<img width="2237" height="1517" alt="image" src="https://github.com/user-attachments/assets/110da2fe-1b88-46d2-892b-8c088f44d683" />      


# Using SurfaceAI Component:    
## 1: create Surface AI Component in Actor which you want to give ability of SurfaceAI :    
<img width="816" height="756" alt="image" src="https://github.com/user-attachments/assets/df029504-9f96-4024-9dba-0842c482cbff" />      
## 2: fill the surface pathfinding data for the actor:      
<img width="3754" height="1908" alt="image" src="https://github.com/user-attachments/assets/36a4b1a2-54c9-4336-a317-50b18b41448e" />     
## 3: use Surface Pathfinding to get the path in Surface:    
<img width="532" height="592" alt="image" src="https://github.com/user-attachments/assets/7c47e8ce-5fd9-4e14-83f0-9de2eeb87567" />
start Pos: is the position the actor start moving     
End Pos: is the position the actor End moving     
if return false, means the Start Position and End Position you filled is not reachable     


## 4: you can draw the path for debuging :     
<img width="1960" height="1183" alt="image" src="https://github.com/user-attachments/assets/58f2f903-d5f9-4fdd-b3ba-aa9e9eab0c77" />     


