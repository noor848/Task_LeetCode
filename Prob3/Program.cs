/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode l3 = new ListNode(0);
        ListNode l4 = l3;
        int raise = 0;

        while (l1 != null && l2 != null)
        {

            int result = l1.val + l2.val + raise;
            if (result < 10)
            {

                l3.next = new ListNode(result);
                l3 = l3.next;
                raise = 0;
            }

            else
            {

                int reminder = result % 10;
                raise = 1;
                l3.next = new ListNode(reminder);
                l3 = l3.next;

            }
            l1 = l1.next;
            l2 = l2.next;


        }

        if (l2 == null && l1 != null)
        {
            if (raise == 0)
            {
                l3.next = l1;
            }
            else
            {
                l3.next = l1;
                while (l1 != null)
                {
                    int result = l1.val + raise;
                    if (result < 10)
                    {
                        l1.val = result;

                        raise = 0;
                        break;
                    }
                    else
                    {
                        int reminder = result % 10;
                        raise = 1;
                        l1.val = reminder;
                    }
                    if (l1.next == null && raise == 1)
                    {
                        l1.next = new ListNode(raise);
                        break;

                    }


                    l1 = l1.next;

                }








            }



        }


        else if (l1 == null && l2 != null)
        {
            if (raise == 0)
            {
                l3.next = l2;
            }
            else
            {
                l3.next = l2;
                while (l2 != null)
                {
                    int result = l2.val + raise;
                    if (result < 10)
                    {
                        l2.val = result;

                        raise = 0;
                        break;
                    }
                    else
                    {
                        int reminder = result % 10;
                        raise = 1;
                        l2.val = reminder;
                    }
                    if (l2.next == null && raise == 1)
                    {
                        l2.next = new ListNode(raise);
                        break;

                    }


                    l2 = l2.next;

                }


            }



        }

        else if (l1 == null && l2 == null && raise == 1)
        {
            while (l3.next != null)
            {
                l3 = l3.next;
            }
            l3.next = new ListNode(raise);
            l3 = l3.next;

        }

        return l4.next;



    }


}