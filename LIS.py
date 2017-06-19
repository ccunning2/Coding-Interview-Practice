#To find the longest increasing subsequence of a sequence.
def lis(A):
    n = len(A)
    q = []

    for k in range(0,n):
        max = 0
        q.append(0)
        for j in range(0,k):
            if A[k] > A[j]:
                if q[j] > max:
                    max = q[j]
        q[k] = max + 1
    max = 0
    for i in range(0,n):
        if q[i] > max:
            max = q[i]
    
    return max
