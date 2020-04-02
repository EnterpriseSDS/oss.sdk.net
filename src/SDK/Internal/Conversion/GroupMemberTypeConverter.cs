using System;
using OneSpanSign.API;

namespace OneSpanSign.Sdk
{
    internal class GroupMemberTypeConverter
    {
        private GroupMemberType groupMemberType;
        private string memberType;

        public GroupMemberTypeConverter( GroupMemberType groupMemberType )
        {
            this.groupMemberType = groupMemberType;
        }

        public GroupMemberTypeConverter( string memberType ) {
            this.memberType = memberType;
        }

        internal string ToAPIMemberType() {
            if (null == groupMemberType)
            {
                return memberType;
            }
            return groupMemberType.getApiValue();
        }

        internal GroupMemberType ToSDKGroupMemberType() {
            if (GroupMemberType.MANAGER.Equals(memberType))
            {
                return GroupMemberType.MANAGER;
            }
            else if (GroupMemberType.REGULAR.Equals(memberType))
            {
                return GroupMemberType.REGULAR;
            }
            else
            {
                return GroupMemberType.valueOf(memberType);            
            }
        }
    }
}
