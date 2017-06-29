def quicksort(array, low = 0, high = None):
    if high is None:
        high = len(array) - 1
    if low < high:  
        leftWall = partition(array, low, high)  
        quicksort(array, low, leftWall - 1)
        quicksort(array, leftWall + 1, high)
    return array


def partition(array, low, high):
    i = low - 1
    pivot = array[high]
    for j in range(low, high):
        if array[j] <= pivot:
            i = i + 1
            array[i], array[j] = array[j], array[i]
    array[i+1], array[high] = array[high], array[i+1]
    return i + 1


test = [21, 4, 1, 3, 9, 20, 25, 6, 21, 14]
print(quicksort(test))
