namespace Web.Model1
{

    public class StoriesModel
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public Additional_Data additional_data { get; set; }
        public int count { get; set; }
        public Item[] items { get; set; }
    }

    public class Additional_Data
    {
        public object ad_expiry_timestamp_in_millis { get; set; }
        public object app_sticker_info { get; set; }
        public bool can_gif_quick_reply { get; set; }
        public bool can_react_with_avatar { get; set; }
        public bool can_reply { get; set; }
        public bool can_reshare { get; set; }
        public string[] disabled_reply_types { get; set; }
        public int expiring_at { get; set; }
        public string id { get; set; }
        public object is_cta_sticker_available { get; set; }
        public bool is_nux { get; set; }
        public int latest_reel_media { get; set; }
        public string reel_type { get; set; }
        public object should_treat_link_sticker_as_cta { get; set; }
        public bool show_fan_club_stories_teaser { get; set; }
        public User user { get; set; }
    }

    public class User
    {
        public string full_name { get; set; }
        public string id { get; set; }
        public long interop_messaging_user_fbid { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Item
    {
        public int archive_story_deletion_ts { get; set; }
        public string attribution_content_url { get; set; }
        public bool can_play_spotify_audio { get; set; }
        public bool can_reply { get; set; }
        public bool can_reshare { get; set; }
        public bool can_save { get; set; }
        public bool can_send_custom_emojis { get; set; }
        public bool can_send_prompt { get; set; }
        public object caption { get; set; }
        public bool caption_is_edited { get; set; }
        public double caption_position { get; set; }
        public object[] clips_tab_pinned_user_ids { get; set; }
        public string code { get; set; }
        public Comment_Inform_Treatment comment_inform_treatment { get; set; }
        public string commerciality_status { get; set; }
        public bool created_from_add_yours_browsing { get; set; }
        public string[] crosspost { get; set; }
        public int deleted_reason { get; set; }
        public long device_timestamp { get; set; }
        public int expiring_at { get; set; }
        public Fb_User_Tags fb_user_tags { get; set; }
        public int filter_type { get; set; }
        public Fundraiser_Tag fundraiser_tag { get; set; }
        public bool has_liked { get; set; }
        public int has_shared_to_fb { get; set; }
        public bool has_translation { get; set; }
        public string id { get; set; }
        public bool ig_media_sharing_disabled { get; set; }
        public Image_Versions image_versions { get; set; }
        public int imported_taken_at { get; set; }
        public string integrity_review_decision { get; set; }
        public object[] invited_coauthor_producers { get; set; }
        public bool is_auto_created { get; set; }
        public bool is_comments_gif_composer_enabled { get; set; }
        public bool is_cutout_sticker_allowed { get; set; }
        public bool is_fb_post_from_fb_story { get; set; }
        public bool is_first_take { get; set; }
        public bool is_in_profile_grid { get; set; }
        public bool is_open_to_public_submission { get; set; }
        public bool is_organic_product_tagging_eligible { get; set; }
        public bool is_paid_partnership { get; set; }
        public bool is_post_live_clips_media { get; set; }
        public bool is_reel_media { get; set; }
        public bool is_reshare_of_text_post_app_media_in_ig { get; set; }
        public bool is_terminal_video_segment { get; set; }
        public bool is_unified_video { get; set; }
        public bool is_video { get; set; }
        public bool like_and_view_counts_disabled { get; set; }
        public object[] likers { get; set; }
        public string media_name { get; set; }
        public int media_type { get; set; }
        public string mezql_token { get; set; }
        public object music_metadata { get; set; }
        public string open_carousel_submission_state { get; set; }
        public int original_height { get; set; }
        public int original_width { get; set; }
        public Owner owner { get; set; }
        public object[] product_suggestions { get; set; }
        public string product_type { get; set; }
        public Sharing_Friction_Info sharing_friction_info { get; set; }
        public object shop_routing_user_id { get; set; }
        public object[] story_astrology_stickers { get; set; }
        public Story_Feed_Media[] story_feed_media { get; set; }
        public bool supports_reel_reactions { get; set; }
        public int taken_at { get; set; }
        public DateTime taken_at_date { get; set; }
        public string thumbnail_url { get; set; }
        public User1 user { get; set; }
        public bool has_audio { get; set; }
        public int is_dash_eligible { get; set; }
        public int number_of_qualities { get; set; }
        public Reel_Mentions[] reel_mentions { get; set; }
        public Story_Link_Stickers[] story_link_stickers { get; set; }
        public Story_Music_Stickers[] story_music_stickers { get; set; }
        public string video_codec { get; set; }
        public float video_duration { get; set; }
        public string video_url { get; set; }
        public Video_Versions[] video_versions { get; set; }
    }

    public class Comment_Inform_Treatment
    {
        public object action_type { get; set; }
        public bool should_have_inform_treatment { get; set; }
        public string text { get; set; }
        public object url { get; set; }
    }

    public class Fb_User_Tags
    {
        public object[] _in { get; set; }
    }

    public class Fundraiser_Tag
    {
        public bool has_standalone_fundraiser { get; set; }
    }

    public class Image_Versions
    {
        public Item1[] items { get; set; }
    }

    public class Item1
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Owner
    {
        public object[] account_badges { get; set; }
        public Fan_Club_Info fan_club_info { get; set; }
        public string fbid_v2 { get; set; }
        public bool feed_post_reshare_disabled { get; set; }
        public string full_name { get; set; }
        public bool has_anonymous_profile_picture { get; set; }
        public string id { get; set; }
        public bool is_favorite { get; set; }
        public bool is_private { get; set; }
        public bool is_unpublished { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public bool show_account_transparency_details { get; set; }
        public int third_party_downloads_enabled { get; set; }
        public bool transparency_product_enabled { get; set; }
        public string username { get; set; }
    }

    public class Fan_Club_Info
    {
        public object autosave_to_exclusive_highlight { get; set; }
        public object connected_member_count { get; set; }
        public object fan_club_id { get; set; }
        public object fan_club_name { get; set; }
        public object fan_consideration_page_revamp_eligiblity { get; set; }
        public object has_enough_subscribers_for_ssc { get; set; }
        public object is_fan_club_gifting_eligible { get; set; }
        public object is_fan_club_referral_eligible { get; set; }
        public object subscriber_count { get; set; }
    }

    public class Sharing_Friction_Info
    {
        public object bloks_app_url { get; set; }
        public object sharing_friction_payload { get; set; }
        public bool should_have_sharing_friction { get; set; }
    }

    public class User1
    {
        public object[] account_badges { get; set; }
        public Fan_Club_Info1 fan_club_info { get; set; }
        public string fbid_v2 { get; set; }
        public bool feed_post_reshare_disabled { get; set; }
        public string full_name { get; set; }
        public bool has_anonymous_profile_picture { get; set; }
        public string id { get; set; }
        public bool is_favorite { get; set; }
        public bool is_private { get; set; }
        public bool is_unpublished { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public bool show_account_transparency_details { get; set; }
        public int third_party_downloads_enabled { get; set; }
        public bool transparency_product_enabled { get; set; }
        public string username { get; set; }
    }

    public class Fan_Club_Info1
    {
        public object autosave_to_exclusive_highlight { get; set; }
        public object connected_member_count { get; set; }
        public object fan_club_id { get; set; }
        public object fan_club_name { get; set; }
        public object fan_consideration_page_revamp_eligiblity { get; set; }
        public object has_enough_subscribers_for_ssc { get; set; }
        public object is_fan_club_gifting_eligible { get; set; }
        public object is_fan_club_referral_eligible { get; set; }
        public object subscriber_count { get; set; }
    }

    public class Story_Feed_Media
    {
        public float end_time_ms { get; set; }
        public float height { get; set; }
        public string id { get; set; }
        public int is_fb_sticker { get; set; }
        public int is_hidden { get; set; }
        public int is_pinned { get; set; }
        public int is_sticker { get; set; }
        public string media_code { get; set; }
        public string media_compound_str { get; set; }
        public string product_type { get; set; }
        public float rotation { get; set; }
        public float start_time_ms { get; set; }
        public float width { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int z { get; set; }
        public string clips_creation_entry_point { get; set; }
    }

    public class Reel_Mentions
    {
        public string display_type { get; set; }
        public float end_time_ms { get; set; }
        public float height { get; set; }
        public int is_fb_sticker { get; set; }
        public int is_hidden { get; set; }
        public int is_pinned { get; set; }
        public int is_sticker { get; set; }
        public float rotation { get; set; }
        public float start_time_ms { get; set; }
        public User2 user { get; set; }
        public float width { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int z { get; set; }
    }

    public class User2
    {
        public string full_name { get; set; }
        public string id { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Story_Link_Stickers
    {
        public float end_time_ms { get; set; }
        public float height { get; set; }
        public int is_fb_sticker { get; set; }
        public int is_hidden { get; set; }
        public int is_pinned { get; set; }
        public int is_sticker { get; set; }
        public float rotation { get; set; }
        public float start_time_ms { get; set; }
        public Story_Link story_link { get; set; }
        public float width { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int z { get; set; }
    }

    public class Story_Link
    {
        public string click_id { get; set; }
        public string display_url { get; set; }
        public string link_title { get; set; }
        public string link_type { get; set; }
        public string url { get; set; }
    }

    public class Story_Music_Stickers
    {
        public string attribution { get; set; }
        public string display_type { get; set; }
        public float end_time_ms { get; set; }
        public float height { get; set; }
        public int is_fb_sticker { get; set; }
        public int is_hidden { get; set; }
        public int is_pinned { get; set; }
        public int is_sticker { get; set; }
        public Music_Asset_Info music_asset_info { get; set; }
        public double rotation { get; set; }
        public float start_time_ms { get; set; }
        public float width { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int z { get; set; }
    }

    public class Music_Asset_Info
    {
        public bool allow_media_creation_with_music { get; set; }
        public bool allows_saving { get; set; }
        public object artist_id { get; set; }
        public string audio_asset_id { get; set; }
        public int audio_asset_start_time_in_ms { get; set; }
        public object[] audio_filter_infos { get; set; }
        public string audio_id { get; set; }
        public Audio_Muting_Info audio_muting_info { get; set; }
        public object contains_lyrics { get; set; }
        public string cover_artwork_thumbnail_uri { get; set; }
        public string cover_artwork_uri { get; set; }
        public object dark_message { get; set; }
        public object derived_content_id { get; set; }
        public string display_artist { get; set; }
        public object display_labels { get; set; }
        public int duration_in_ms { get; set; }
        public string fast_start_progressive_download_url { get; set; }
        public object formatted_clips_media_count { get; set; }
        public bool has_lyrics { get; set; }
        public int[] highlight_start_times_in_ms { get; set; }
        public string id { get; set; }
        public Ig_Artist ig_artist { get; set; }
        public string ig_username { get; set; }
        public bool is_bookmarked { get; set; }
        public object is_eligible_for_audio_effects { get; set; }
        public bool is_explicit { get; set; }
        public bool is_trending_in_clips { get; set; }
        public int overlap_duration_in_ms { get; set; }
        public string placeholder_profile_pic_url { get; set; }
        public string progressive_download_url { get; set; }
        public object reactive_audio_download_url { get; set; }
        public object sanitized_title { get; set; }
        public bool should_allow_music_editing { get; set; }
        public bool should_mute_audio { get; set; }
        public string should_mute_audio_reason { get; set; }
        public object should_mute_audio_reason_type { get; set; }
        public string subtitle { get; set; }
        public string title { get; set; }
        public object trend_rank { get; set; }
        public object web_30s_preview_download_url { get; set; }
    }

    public class Audio_Muting_Info
    {
        public bool allow_audio_editing { get; set; }
        public bool mute_audio { get; set; }
        public string mute_reason_str { get; set; }
        public bool show_muted_audio_toast { get; set; }
    }

    public class Ig_Artist
    {
        public string full_name { get; set; }
        public string id { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Video_Versions
    {
        public int height { get; set; }
        public string id { get; set; }
        public int type { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

}