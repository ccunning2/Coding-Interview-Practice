def binary_search(arr, value):
    low = 0
    high = len(arr)
    mid = (low + high) / 2

    while low <= high:
        mid = (low + high) / 2
        if arr[mid] < value:
            low = mid + 1
        elif arr[mid] > value:
            high = mid - 1
        else:
            return mid
    
    return -1
