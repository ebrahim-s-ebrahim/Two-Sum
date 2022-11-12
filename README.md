# Two Sum using Dictionary class in c#

The best way to approch this problem is by creating an empty dictionary, where the keys will be the elements of the given array, and the values will be the indices of the elements.            
By subtracting the the target and the key, we check if the result is in the dictionary or not.              
If found, we return the value of the selected element (the index in the array) along with the current index.                    
If not found, we add it to the dictionary and proceed to the next one.
