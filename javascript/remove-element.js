/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function(nums, val) {
   let index = nums.indexOf(val);
       if (nums.indexOf(val) < 0){
           return nums.length;
       }
   nums.splice(index, 1);
   removeElement(nums, val);
};
