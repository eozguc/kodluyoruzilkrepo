# [22,27,16,2,18,6] -> Insertion Sort

### Yukarıda verilen dizinin sort türüne göre aşamalarını yazınız.
``` 
 1- [22,27,16,2,18,6]
 2- [16,22,27,2,18,6]
 3- [2,16,22,27,18,6]
 4- [2,16,18,22,27,6]
 5- [2,6,16,18,22,27]
```
### Big-O gösterimini yazınız.
```
1- Insertion Sort--> O(n²)
```
### Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
```
Average case: O(n²) 
Worst case: O(n²)
Best case: O(n) 
```
### Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.

#### 1- *Average Case*
```
[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.
[3,7|5,8,2,9,4,15,6]
[3,5,7|8,2,9,4,15,6]
[3,5,7,8|2,9,4,15,6]
[2,3,5,7,8|9,4,15,6]
```
