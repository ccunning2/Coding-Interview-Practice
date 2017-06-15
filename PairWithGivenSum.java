import java.util.HashMap;

public class PairWithGivenSum {

	/*
	 * Given an unsorted array and a givenSum, find a pair whose sum == givenSum
	 * Example: givenArr = [8,7,2,5,3,1] gienSum = 10
	 * Return: Pair found at index 0 and 2 (8 + 2) 
	 */
	
	public static String givenSum(int[] givenArr, int givenSum) {
		//First, put all values into hashmap. Key is the int itself, value is position in givenArr. O(n)
		HashMap<Integer, Integer> values = new HashMap<>(givenArr.length);
		for (int i = 0; i < givenArr.length; i++){
			values.put(givenArr[i], i);
		}
		//Iterate through array and search for givenSum - givenArr[i] in HashMap (values) O(n)
		int target;
		for(int i : givenArr){
			target = givenSum - i;
			if ( values.containsKey(target) ) {
				return "Pair found at index " + values.get(i) + " and " + values.get(target) + " (" + i + " + " + target + ")";
			}
		}
		return "Pair matching " + givenSum + " not found.";
		//O(2n) algorithm. Space: O(n)
	}
	public static void main(String[] args) {
		//Test with example values
		int[] arr = {8,7,2,5,3,1};
		System.out.println(givenSum(arr, 10));
	}

}
