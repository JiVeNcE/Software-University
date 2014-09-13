/**
 * Created by Zhivko on 26.7.2014 г..
 */

function findLargestBySumOfDigits(nums) {

    var maxSum = 0;
    var result = 0;


    for (var i = 0; i < nums.length; i++) {
        if ( nums[i] != parseInt(nums[i])){
            return undefined;
        }
            var temp = nums[i];
            if ( nums[i] < 0){
                nums[i] *= -1;
            }
            var momSum = 0;
            while ( nums[i] > 0) {

                momSum += nums[i] % 10;
                nums[i] = Math.floor(nums[i] / 10);
            }

        if ( momSum > maxSum){
            maxSum = momSum;
            result = temp;
        }

    }
    return result;
}

    console.log(findLargestBySumOfDigits([5, 10, 15, 111]));
    console.log(findLargestBySumOfDigits([33, 44, -99, 0, 20]));
    console.log(findLargestBySumOfDigits(['hello']));
    console.log(findLargestBySumOfDigits([5, 3.3]));