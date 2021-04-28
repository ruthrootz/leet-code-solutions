/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDuplicates = function(nums) {
    let matches = [];
    for (let i = 0; i < nums.length; i++) {
        let temp = Math.abs(nums[i]) - 1;
        nums[temp] = -nums[temp];
        if (nums[temp] > 0) {
            matches.push(temp + 1);
        }
    }
    return matches;
};
