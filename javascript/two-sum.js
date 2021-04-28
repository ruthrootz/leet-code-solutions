/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    // WORKS - FASTEST
    for (let i = 0; i < nums.length - 1; ++i) {
        for (let j = i + 1; j < nums.length; ++j) {
            if (nums[i] + nums[j] == target) {
                return [i, j];
            }
        }
    }
    /* WORKS BUT VERY SLOW
    while(true) {
        let i = Math.floor(Math.random() * nums.length);
        let j = Math.floor(Math.random() * nums.length);
        if (i != j && nums[i] + nums[j] == target) {
            if (i < j) {
                return [i, j];
            }
            else {
                return [j, i];
            }
        }
    }
    */
    /* WORKS
    // for each num, try to find the num needed to reach target
    let needed;
    for (let i = 0; i < nums.length; i++) {
        needed = target - nums[i];
        for (let j = 0; j < nums.length; j++) {
            if (j == i) {
                continue;
            }
            else if (nums[j] == needed) {
                return [i, j];
            }
        }
    }
    */
    /* WORKS
    let arrayNeeded = [];
    for (let i = 0; i < nums.length; i++) {
        arrayNeeded[i] = target - nums[i];
    }
    for (let j = 0; j < arrayNeeded.length; j++) {
        if (nums.includes(arrayNeeded[j]) && j != nums.indexOf(arrayNeeded[j])) {
            return [j, nums.indexOf(arrayNeeded[j])];
        }
    }
    */
    /* DEETER'S CODE
    ouside function:
    let positives = [];
    let negatives = [];
    let getArray = (x) => {
        if (x >= 0) {
            return positives;
        }
        return negatives;
    };
    inside function:
    for (let x = 0; x < nums.length; x++) {
        let current = nums[x];
        let array = getArray(nums[x]);
        if (array[Math.abs(target - current)] != undefined) {
            return [x, array[Math.abs(nums[x])]];
        }
        else {
            getArray(target - current)[Math.abs(target - current)] = x;
        }
    }
    */
};
