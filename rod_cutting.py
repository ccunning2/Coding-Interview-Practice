#The 'rod cutting' dynamic programming problem. Given a rod length, and a price map of
# lengths and prices, maximize the price that can be obtained

#input: A price map, where the keys are lengths of rod, and the price is how much a rod of that
#length costs (range is from 1 to n, where n is the max length). The length is the length of rod, the price of which you want to maximize.
def rod_cut(price_list, length):
	newList = []
	newList.append(0)
	for j in range(1, length + 1):
		q = -1
		for i in range(1,j + 1):
			q = max(q, price_list[i-1] + newList[j - i])
		newList.append(q)
	return newList[length]


#Test Code
prices = [1,5,8,9,10,17,17,20,24,30]
length = 7
print(rod_cut(prices, length)) #Matches expected value of 18
